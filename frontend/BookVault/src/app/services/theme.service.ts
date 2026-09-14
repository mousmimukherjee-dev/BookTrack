import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ThemeService {

  // This is the theme currently being used.
  // We start with dark mode.
  currentTheme: 'light' | 'dark' = 'dark';

  constructor() {

    // Check if the user already selected a theme before.
    const savedTheme = localStorage.getItem('theme');

    // If we found a saved theme, use it.
    if (savedTheme === 'light' || savedTheme === 'dark') {
      this.currentTheme = savedTheme;
    }

    // Apply the theme when the application starts.
    this.applyTheme();
  }

  // Switch between light and dark mode.
  toggleTheme() {

    if (this.currentTheme === 'dark') {

      // Change dark → light
      this.currentTheme = 'light';

    } else {

      // Change light → dark
      this.currentTheme = 'dark';
    }

    // Remember the user's choice.
    localStorage.setItem('theme', this.currentTheme);

    // Apply the new theme.
    this.applyTheme();
  }

  // Tell Bootstrap which theme to use.
  private applyTheme() {

    document.documentElement.setAttribute(
      'data-bs-theme',
      this.currentTheme
    );
  }
}