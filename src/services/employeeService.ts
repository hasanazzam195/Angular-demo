import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { employee } from "src/data/employee";

@Injectable()
export class employeeService{

    constructor(private HttpCli:HttpClient){}

    loadCountry():Observable<any>{
        debugger;
      return this.HttpCli.get("http://localhost/AngularDemo/api/Employee/loadCountry");
    }

    Insert(emp:employee){
        debugger;
        this.HttpCli.post("http://localhost/AngularDemo/api/Employee",emp).subscribe();
    }

    loadByName(name:string):Observable<any>{
        debugger;
        return this.HttpCli.get("http://localhost/AngularDemo/api/Employee/LoadByName/"+name);
    }
}