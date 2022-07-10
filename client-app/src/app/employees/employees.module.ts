import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { EmployeesRoutingModule } from './employees-routing.module';
import { EmployeesLayoutComponent } from './employees-layout/employees-layout.component';
import { EmployeesListComponent } from './employees-list/employees-list.component';
import { MatTableModule } from '@angular/material/table';

@NgModule({
  declarations: [
    EmployeesLayoutComponent,
    EmployeesListComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    EmployeesRoutingModule,
    MatTableModule,
  ],
  exports: [
    EmployeesLayoutComponent,
    EmployeesListComponent,
    MatTableModule
  ]
})
export class EmployeesModule { }
