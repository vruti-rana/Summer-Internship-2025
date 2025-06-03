import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  username: string = '';
  password: string = '';
  submitted: boolean = false;

  onLogin(event: Event) {
    event.preventDefault();
    this.submitted = true;

    if (!this.username || !this.password) {
      console.log('Please fill in all fields');
      return;
    }

    console.log('Username:', this.username);
    console.log('Password:', this.password);
  }
}
