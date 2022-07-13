import { LiveAnnouncer } from '@angular/cdk/a11y';
import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Crew } from 'src/app/_models/crew.model';
import { Employee } from 'src/app/_models/employee.model';
import { JobTitle } from 'src/app/_models/jobTitle.model';
import { RuleType } from 'src/app/_models/ruleType.model';
import { EmployeeService } from 'src/app/_services/employee.service';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.scss']
})
export class EmployeesListComponent implements OnInit {
  displayedColumns: string[] = ['id', 'firstName', 'lastName', 'phoneNumber', 'crew', 'jobTitle', 'ruleType'];
  columnsToDisplay: string[] = [...this.displayedColumns, 'actions'];
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  employees: Employee[];
  dataSource = new MatTableDataSource<Employee>();
  employee: Employee;
  sortSelected: string;
  sortOptions = [
    { name: 'Alpabetical', value: 'firstName' },
    { name: 'Id: Ascending', value: 'idAsc' },
    { name: 'Id: Descending', value: 'idDesc' },
    { name: 'Crews', value: 'crew' },
    { name: 'Job Titles', value: 'jobTitle' },
    { name: 'Rule Types', value: 'ruleType' }
  ];
  // Load foreign table data..
  crews: Crew[];
  jobTitles: JobTitle[];
  ruleTypes: RuleType[];

  crewIdSelected: number;

  constructor(private employeeService: EmployeeService) { }

  ngOnInit(): void {
    this.getEmployees();
    this.getCrews();
    this.getJobTitles();
    this.getRuleTypes();
  }

  getEmployees() {
    this.employeeService.getAll(this.sortSelected).subscribe(response => {
      this.employees = response.data;
      this.dataSource = new MatTableDataSource<Employee>(this.employees);
    }, error => {
      console.log(error);
    });
  }

  getCrews() {
    this.employeeService.getCrews().subscribe(response => {
      this.crews = [{id: 0, name: 'All'}, ...response];
    }, error => {
      console.log(error);
    })
  }

  getJobTitles() {
    this.employeeService.getJobTitles().subscribe(response => {
      this.jobTitles = [{id: 0, name: 'All'}, ...response];
    }, error => {
      console.log(error);
    })
  }

  getRuleTypes() {
    this.employeeService.getRuleTypes().subscribe(response => {
      this.ruleTypes = [{id: 0, name: 'All'}, ...response];
    }, error => {
      console.log(error);
    })
  }

  employeeDetails = (id: number) => {
    this.employeeService.getById(id).subscribe((response: any) => {
      this.employee = response;
    })
  }

  onSortSelected(sort: string) {
    this.sortSelected = sort;
  }
}
