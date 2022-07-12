import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Employee } from 'src/app/_models/employee.model';
import { EmployeeService } from 'src/app/_services/employee.service';
import { EmployeeComponent } from '../employee/employee.component';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.scss']
})
export class EmployeesListComponent implements OnInit {
  displayedColumns: string[] = ['id', 'firstName', 'lastName', 'phoneNumber', 'crew', 'jobTitle', 'ruleType'];
  columnsToDisplay: string[] = [...this.displayedColumns, 'actions'];
  employees: any[];
  employee: Employee;

  constructor(private employeeService: EmployeeService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.employeeService.getAll().subscribe((response: any) => {
      this.employees = response;
    }, error => {
      console.log(error);
    });
  }

  employeeDetails = (id: number) => {
    this.employeeService.getById(id).subscribe((response: any) => {
      this.employee = response;
    })
  }
}
