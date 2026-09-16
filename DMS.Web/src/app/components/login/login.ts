import { Component, inject } from '@angular/core';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators
} from '@angular/forms';
import { Router } from '@angular/router';

import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';

import { AuthService } from '../../core/services/auth';
import { LoginRequest } from '../../models/login-request';

@Component({
  selector: 'app-login',
  imports: [
    ReactiveFormsModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule
  ],
  templateUrl: './login.html',
  styleUrl: './login.scss',
})
export class Login {

  private readonly authService = inject(AuthService);
  private readonly router = inject(Router);

  loginError = '';

  readonly loginForm = new FormGroup({

    email: new FormControl('', {
      nonNullable: true,
      validators: [
        Validators.required,
        Validators.email
      ]
    }),

    password: new FormControl('', {
      nonNullable: true,
      validators: [
        Validators.required
      ]
    })

  });

  login(): void {

    if (this.loginForm.invalid) {
      return;
    }

    this.loginError = '';

    const request: LoginRequest = {
      email: this.loginForm.controls.email.value,
      password: this.loginForm.controls.password.value
    };

    this.authService.login(request).subscribe({

      next: result => {
        console.log('Zalogowano');
        console.log(result);
        console.log('Token:', result.data.accessToken);
        console.log('Role:', result.data.userRole);

        this.router.navigate(['/dashboard']);
      },

      error: error => {
        this.loginError = error.message;
        console.error('Błąd logowania:', error);
      }

    });
  }
}