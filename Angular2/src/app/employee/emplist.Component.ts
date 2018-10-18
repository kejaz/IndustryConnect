import { Component } from '@angular/core'

@Component({
    selector: 'emplist-app',
    templateUrl: 'app/employee/emplist.html'
})
export class EmplistComponent {
    name: string = "Kashif Ejaz"
    age: string = "38 Years"
    salary: string = "1500"
    department: string  = "IT"
}