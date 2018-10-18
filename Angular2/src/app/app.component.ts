import { Component } from  '@angular/core'

@Component({
    selector: 'my-app',
    template: `
                <h1>Hello {{name}}</h1>
                <emplist-app>Loading component...</emplist-app>
              `
})
export class AppComponent {
    name: string = "Kashif Ejaz";
}