import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { employee } from 'src/data/employee';
import { employeeService } from 'src/services/employeeService';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  liemployee!:employee[];
  @ViewChild('txtName') txtName!:ElementRef
  constructor( private empService:employeeService ) { }

  ngOnInit(): void {
  }

  Search(){
    debugger;
    
    let name:string=this.txtName.nativeElement.value;
    this.empService.loadByName(name).subscribe(
      data=>{
        debugger;
        this.liemployee=data;
      }
    );
  }

}
