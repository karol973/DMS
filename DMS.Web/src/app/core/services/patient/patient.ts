import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { AuthService } from '../auth';
import { PatientDto } from '../../../models/patient-dto';
import { Observable } from 'rxjs';
import { ApiResponse } from '../../../models/api-response';

@Injectable({
  providedIn: 'root',
})
export class PatientService {
  
  private readonly http = inject(HttpClient);

  private readonly authService = inject(AuthService);

  private readonly apiUrl = `${environment.apiUrl}/Patient`;

  private readonly currentUser = this.authService.currentUser;

  getPatientData(): Observable<ApiResponse<PatientDto>> {
    
    //const userId = this.currentUser()?.id;
    const patientId = this.currentUser()?.patientId;
    //const userId1 = this.currentUser()?.userId;
console.log(patientId);
    if (patientId == null){
      throw new Error('Nie ma takiego pacjenta.')
    }

    return this.http.get<ApiResponse<PatientDto>>(`${this.apiUrl}/${patientId}/patientdata`)
  }
}
