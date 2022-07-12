import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { Employee } from "../_models/employee.model";

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.apiUrl + 'employees');
  }

  getById(id: number): Observable<Employee> {
    return this.http.get<Employee>(this.apiUrl + 'employees/' + id);
  }

  create(params: any) {
    return this.http.get<Employee>(this.apiUrl + 'employees/' + params);
  }

  update(id: number, params: any) {
    return this.http.get<Employee>(this.apiUrl + 'employees/' + params);
  }
}