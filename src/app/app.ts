import { Component, signal } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { Logo } from './components/logo/logo';
import { Header } from './components/header/header';
import { Home } from './components/home/home';
import { Dashboard } from './components/dashboard/dashboard';
import { Quotes } from './components/quotes/quotes';
import { Navbar } from './components/navbar/navbar';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterLink, Header, Home,Navbar, Dashboard, Quotes],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('BookTrack');
}
