import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgIf, NgFor } from '@angular/common';
import { HomeComponent } from './home/home.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
  standalone: true,
  imports: [NgIf, NgFor, HomeComponent]
})
export class AppComponent implements OnInit {
  

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    
  }

  title = 'dashboard.client';
}
