import { Component, signal } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { Logo } from './components/logo/logo';
import { Header } from './components/header/header';
import { Home } from './components/home/home';
import { Dashboard } from './components/dashboard/dashboard';
import { Quotes } from './components/quotes/quotes';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterLink, Header, Home, Dashboard, Quotes],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('BookTrack');
}
