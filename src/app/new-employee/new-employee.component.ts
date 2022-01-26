import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { country } from 'src/data/country';
import { employee } from 'src/data/employee';
import { employeeService } from 'src/services/employeeService';

@Component({
  selector: 'app-new-employee',
  templateUrl: './new-employee.component.html',
  styleUrls: ['./new-employee.component.css']
})
export class NewEmployeeComponent implements OnInit {
  @ViewChild('f') employeeForm!:NgForm
  liCountry!:country[];

  constructor(private empservice:employeeService) { }

  ngOnInit(): void {
    this.empservice.loadCountry().subscribe(
      data=>{
        debugger;
        this.liCountry=data;
      }
    );
  }

  Save(){
    var emp=new employee();
    debugger;
    emp.name=this.employeeForm.value["txtName"];
    emp.phone=this.employeeForm.value["txtPhone"];
    emp.salary=parseFloat(this.employeeForm.value["txtSalary"]);
    emp.country_id=parseInt(this.employeeForm.value["ddlcountry"]);
     
    this.empservice.Insert(emp);
  }

}
