import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Song } from 'src/Models/song.Model';



@Injectable({
  providedIn: 'root'
})

export class DilserviceService {
  S: any ;
  baseApiUrl : string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllSongsList(): Observable<Song[]>{
    return this.http.get<Song[]>(this.baseApiUrl + 'api/API');
  }

  getsonglistname(value:string): Observable<any>{
    return this.http.get<any>(this.baseApiUrl + 'api/API/get/new/' + value);
  }

}



