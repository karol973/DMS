import { Component, inject, OnInit, signal } from '@angular/core';
import { PatientService } from '../../core/services/patient/patient';
import { PatientDto } from '../../models/patient-dto';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatDividerModule } from '@angular/material/divider';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { AuthService } from '../../core/services/auth';

@Component({
  selector: 'app-dashboard',
  imports: [
    MatCardModule,
    MatButtonModule,
    MatIconModule,
    MatProgressSpinnerModule,
    MatDividerModule,
    MatButtonModule,
    MatSidenavModule,
    MatListModule
  ],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.scss',
})
export class DashboardComponent implements OnInit{

  private readonly patientService = inject(PatientService);
  private readonly authService = inject(AuthService);

  patient = signal<PatientDto | null>(null);
  isLoading = signal(true);
  errorMessage = signal<string | null>(null);

  ngOnInit(): void {
    this.patientService.getPatientData().subscribe({
      next: response => {
        this.patient.set(response.data);
        this.isLoading.set(false);
      },
      error: err => {
        this.errorMessage = err.message;
        this.isLoading = err.false;
      }
    })
  }

  logout():void {
    this.authService.logout();
  }

}
