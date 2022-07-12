import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { EmployeesRoutingModule } from './employees-routing.module';
import { EmployeesLayoutComponent } from './employees-layout/employees-layout.component';
import { EmployeesListComponent } from './employees-list/employees-list.component';
import { MatTableModule } from '@angular/material/table';
import { MatCardModule } from '@angular/material/card';
import { MatDialogModule } from '@angular/material/dialog';
import { EmployeeComponent } from './employee/employee.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';


@NgModule({
  declarations: [
    EmployeesLayoutComponent,
    EmployeesListComponent,
    EmployeeComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    ReactiveFormsModule,
    FormsModule,
    EmployeesRoutingModule,
    MatTableModule,
    MatInputModule,
    MatCardModule,
    MatDialogModule,
    MatFormFieldModule,
    MatIconModule,
    MatButtonModule
  ],
  exports: [
    EmployeesLayoutComponent,
    EmployeesListComponent,
    EmployeeComponent,
    ReactiveFormsModule,
    FormsModule,
    MatTableModule,
    MatInputModule,
    MatCardModule,
    MatDialogModule,
    MatFormFieldModule,
    MatIconModule,
    MatButtonModule
  ]
})
export class EmployeesModule { }
