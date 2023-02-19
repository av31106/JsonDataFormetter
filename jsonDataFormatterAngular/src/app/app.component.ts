import { JsonPipe } from '@angular/common';
import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'jsonDataFormatter';
  

  constructor(private httpClient: HttpClient) {
  }

  format(inputTextArea: HTMLTextAreaElement) {
    let url = environment.baseURL + environment.FormatJsonDataApiUrl
    let formData = new FormData();
    formData.append("jsonString", inputTextArea.value);
    const headers = { 'accept': 'text/plain; charset=utf-8' };
    this.httpClient.post(url, formData, { headers }).subscribe((result) => {
      inputTextArea.value = JSON.stringify(result, undefined, 2);
    });
  }

  removeWhiteSpaces(inputTextArea: HTMLTextAreaElement) {
    let url = environment.baseURL + environment.RemoveWhiteSpaceApiUrl
    let formData = new FormData();
    formData.append("jsonString", inputTextArea.value);
    this.httpClient.post(url, formData).subscribe((result) => {
      inputTextArea.value = JSON.stringify(result);
    });
  }
}
