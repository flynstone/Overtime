import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.scss']
})
export class EmployeesListComponent implements OnInit {
  displayedColumns: string[] = ['id', 'firstName', 'lastName', 'phoneNumber', 'crew', 'jobTitle', 'ruleType'];
  employees: any[];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/employees').subscribe((response: any) => {
      this.employees = response;
    }, error => {
      console.log(error);
    });
  }

}
