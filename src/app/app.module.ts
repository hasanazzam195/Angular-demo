import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NewEmployeeComponent } from './new-employee/new-employee.component';
import { EmployeeListComponent } from './employee-list/employee-list.component';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http'
import { employeeService } from 'src/services/employeeService';
import { FormsModule } from '@angular/forms';


const appRoute:Routes=[
  {path:'new-emp',component:NewEmployeeComponent},
  {path:'',component:EmployeeListComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    NewEmployeeComponent,
    EmployeeListComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoute),
    HttpClientModule,
    FormsModule
  ],
  providers: [employeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
