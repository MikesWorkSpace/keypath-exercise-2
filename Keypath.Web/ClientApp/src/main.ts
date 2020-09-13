import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}

export function getRestAPIBaseUrl() {
  return "https://localhost:44303/api/";
}

const providers = [
  { provide: 'REST_API_BASE_URL', useFactory: getRestAPIBaseUrl, deps: [] }

];


if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic(providers).bootstrapModule(AppModule)
  .catch(err => console.log(err));
