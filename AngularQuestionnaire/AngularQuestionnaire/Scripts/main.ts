import {Component, View, bootstrap, formDirectives} from 'angular2/angular2';
@Component({
    selector: 'my-app'
})
@View({
    directives: [formDirectives],
    templateUrl: 'mainForm.html'
})
class AppComponent {
    name: string;
    hello(): void {
        alert("hello, " + this.name);
    }
    constructor() {
        this.name = "John Doe";
    }
}
bootstrap(AppComponent);