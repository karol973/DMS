import { computed, inject, Injectable, signal } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';
import {catchError, Observable, tap, throwError} from 'rxjs';
import { LoginRequest } from '../../models/login-request';
import { LoginResult } from '../../models/login-result';
import { CurrentUser } from '../../models/current-user';
import { environment } from '../../../environments/environment';
import { ApiResponse } from '../../models/api-response';

@Injectable({ providedIn: 'root' })

export class AuthService {

  private readonly http = inject(HttpClient);
  private readonly router = inject(Router);

  private readonly tokenSignal = signal<string | null>(null);

  private readonly currentUserSignal = signal<CurrentUser | null>(null);

  readonly currentUser = this.currentUserSignal.asReadonly();

  readonly isAuthenticated = computed(
    () => this.tokenSignal() !== null
  );

  private readonly apiUrl = `${environment.apiUrl}/Auth`;

  constructor() {
    this.initializeSession();
  }

  login(request: LoginRequest): Observable<ApiResponse<LoginResult>> {

    return this.http
      .post<ApiResponse<LoginResult>>(
        `${this.apiUrl}/login`,
        request
      )
      .pipe(
        tap(result => {

          const user: CurrentUser = {
            email: request.email,
            role: result.data.userRole,
            id: result.data.id,
            userId: result.data.userId,
            patientId: result.data.patientId,
          };

          this.tokenSignal.set(result.data.accessToken);
          this.currentUserSignal.set(user);

          localStorage.setItem(
            'accessToken',
            result.data.accessToken
          );

          localStorage.setItem(
            'refreshToken',
            result.data.refreshToken
          );

          localStorage.setItem(
            'user',
            JSON.stringify(user)
          );
        }),

        catchError(error =>
          this.handleError(error)
        )
      );
  }

  logout(): void {

    this.tokenSignal.set(null);
    this.currentUserSignal.set(null);

    localStorage.removeItem('accessToken');
    localStorage.removeItem('refreshToken');
    localStorage.removeItem('user');

    this.router.navigate(['/login']);
  }

  getToken(): string | null {
    return this.tokenSignal();
  }

  private initializeSession(): void {

    const accessToken =
      localStorage.getItem('accessToken');

    const storedUser =
      localStorage.getItem('user');

    if (!accessToken) {
      return;
    }

    this.tokenSignal.set(accessToken);

    if (storedUser) {
      try {
        this.currentUserSignal.set(
          JSON.parse(storedUser)
        );
      } catch {
        localStorage.removeItem('user');
      }
    }
  }

  private handleError(error: HttpErrorResponse) {

    let errorMessage =
      'Wystąpił nieznany błąd.';

    if (error.status === 0) {
      errorMessage =
        'Nie można połączyć się z serwerem.';
    }
    else if (error.status === 400) {
      errorMessage =
        error.error?.message ??
        'Nieprawidłowe dane.';
    }
    else if (error.status === 401) {
      errorMessage =
        'Nieprawidłowy email lub hasło.';
    }
    else if (error.status >= 500) {
      errorMessage =
        'Wystąpił błąd serwera.';
    }

    return throwError(
      () => new Error(errorMessage)
    );
  }
}