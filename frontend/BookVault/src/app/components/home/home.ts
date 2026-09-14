import { Component, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Header } from '../header/header';
import { AuthService } from '../../services/auth-service';
import { Router } from '@angular/router';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-home',
  imports: [FormsModule, Header],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  loginData: any = {
    email: '',
    password: '',
  };

  registerData: any = {
    name: '',
    email: '',
    password: '',
    confirmPassword: '',
  };

  activeButton = signal<'Sign In' | 'Register'>('Sign In');
  errorMessage = signal<string>('');

  constructor(
    private authService: AuthService,
    private router: Router, public themeService: ThemeService
  ) {}

  showLogin() {
    this.activeButton.set('Sign In');
    this.errorMessage.set('');
  }

  showRegister() {
    this.activeButton.set('Register');
    this.errorMessage.set('');
  }
  
    toggleTheme() {
    this.themeService.toggleTheme();
  } 
  loginUser() {
    this.authService.login(this.registerData).subscribe({
      next: (data: any) => {
        localStorage.setItem('token', data.token);
        this.router.navigate(['/dashboard']);
      },
      error: (error) => {
        console.error('Login error:', error);
        this.errorMessage.set('Invalid email or password.');
      },
    });
  }

  registerUser() {
    if (this.registerData.password !== this.registerData.confirmPassword) {
      this.errorMessage.set('Passwords do not match.');
      return;
    }

    this.authService.register(this.registerData).subscribe({
      next: (data) => {
        this.showLogin();
      },
      error: (error) => {
        console.error('Registration error:', error);
        this.errorMessage.set('Registration failed. Try a different email.');
      },
    });
  }
}
