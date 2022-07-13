import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { environment } from "src/environments/environment";
import { Crew } from "../_models/crew.model";
import { Employee } from "../_models/employee.model";
import { JobTitle } from "../_models/jobTitle.model";
import { Pagination } from "../_models/pagination";
import { RuleType } from "../_models/ruleType.model";

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {
  }

  // Get sorted list of employees.
  getAll(sort?: string) {
    let params = new HttpParams();

    // if (crewId) {
    //   params = params.append('crewId', crewId.toString());
    // }

    // if (jobTitleId) {
    //   params = params.append('jobTitleId', jobTitleId.toString());
    // }

    // if (ruleTypeId) {
    //   params = params.append('ruleTypeId', ruleTypeId.toString());
    // }

    if (sort) {
      params = params.append('sort', sort);
    }

    return this.http.get<Pagination>(this.apiUrl + 'employees', { observe: 'response', params })
      // using rxjs.
      .pipe(
        map(response => {
          return response.body;
        })
      );
  }

  getCrews(): Observable<Crew[]> {
    return this.http.get<Crew[]>(this.apiUrl + 'employees/crews');
  }

  getJobTitles(): Observable<JobTitle[]> {
    return this.http.get<JobTitle[]>(this.apiUrl + 'employees/jobtitles');
  }

  getRuleTypes(): Observable<RuleType[]> {
    return this.http.get<RuleType[]>(this.apiUrl + 'employees/ruletypes');
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