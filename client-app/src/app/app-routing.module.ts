import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';

// Employees module.
const employeesModule = () => import("./employees/employees.module").then(x => x.EmployeesModule);

const routes: Routes = [
  { path: "home", component: HomeComponent, pathMatch: "full" },
  { path: "employees", loadChildren: employeesModule },
  { path: "", redirectTo: "/home", pathMatch: "full" },  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
