import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  username = 'User';

  constructor() {
    console.log('HomeComponent loaded');
  }

  ngOnInit(): void {
    const state = history.state;
    this.username = state.username || 'User';
    console.log('Username from state:', this.username);
  }
}