import { BrowserModule, bootstrapApplication } from '@angular/platform-browser';
import { withInterceptorsFromDi, provideHttpClient } from '@angular/common/http';
import { AppComponent } from './app/app.component';
import { importProvidersFrom } from '@angular/core';
import { PreloadAllModules, PreloadingStrategy, Route, provideRouter } from '@angular/router';

const routes: Route[] = [
  { path: '', loadComponent: () => import('../src/app/home/home.component').then(h => h.HomeComponent), pathMatch: 'full' },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];

bootstrapApplication(AppComponent, {
  providers: [
    importProvidersFrom(BrowserModule),
    provideHttpClient(withInterceptorsFromDi()),
    provideRouter(routes)
    ]
})
  .catch(err => console.error(err));
