import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { EmployeeComponent } from "./employee/employee.component";
import { EmployeesLayoutComponent } from "./employees-layout/employees-layout.component";
import { EmployeesListComponent } from "./employees-list/employees-list.component";

const routes: Routes = [
  {
    path: '', component: EmployeesLayoutComponent,
    children: [
      { path: '', component: EmployeesListComponent },
      { path: 'add', component: EmployeeComponent },
      { path: ':id', component: EmployeeComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmployeesRoutingModule { }