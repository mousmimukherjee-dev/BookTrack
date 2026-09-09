import { Routes } from '@angular/router';
import { Dashboard } from './components/dashboard/dashboard';
import { Home } from './components/home/home';
import { Quotes } from './components/quotes/quotes';
import { DashboardLayout } from './dashboard-layout/dashboard-layout';

export const routes: Routes = [
  {
    path: '',
    component: Home,
  },
  {
    path: 'dashboard',
    component: DashboardLayout,
    children:[

       {
    path: '',
    component: Dashboard,
  },

       {
    path: 'quotes',
    component: Quotes,
  }

    ]
    
  }
 ,
];
