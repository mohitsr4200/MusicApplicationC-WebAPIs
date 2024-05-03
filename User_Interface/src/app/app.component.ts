import { Component, OnInit } from '@angular/core';
import { DilserviceService } from './dilservice.service'
import { Song } from 'src/Models/song.Model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'music';


  Songs : Song[] =[];
  SongID: any ;
  SongName : any ;
  SongGener : any  ;
  SongLocation : any ;
  SONG : any[] =[] ;
  value: any;
  show: boolean = false;
  searchdata : any;
  constructor(private songsservice: DilserviceService) { }

  ngOnInit(): void {
    this.songsservice.getAllSongsList().subscribe((data : Song[])=>{
      console.log(data);
      this.Songs = data;
      data.forEach((item) => {
        this.SONG.push(item.songLocation)
      });
      console.log(this.SONG)
    })
  }
  
  SearchDocument(value: string){
    this.songsservice.getsonglistname(value).subscribe((data : any)=>{
      console.log(data);
      this.Songs= data;
      if(data.isArray()){
        this.searchdata = data ;
      }else{
        this.searchdata.push(data) ;
      }
    //  this.searchdata = this.Songs.find(x => x.songName == value)?.songName;
      if(this.searchdata){
        this.show = true;
      }
      // data.forEach((item) => {
      //   this.SONG.push(item.songLocation)
      // });
    })
  }
 
}








