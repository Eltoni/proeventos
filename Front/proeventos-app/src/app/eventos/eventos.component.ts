import { HttpClient} from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private http: HttpClient) { }
  //public eventos: any = [
   // {
     // Tema: "Angular",
     // Local: "Belo HOrizonte"
    //},
    //{
     // Tema: "Angular 22",
     // Local: "Sp"
    //},
//]
public eventos: any;

  ngOnInit(): void {

    this.getEventos();
  }


  public getEventos(): void {
    this.http.get("https://localhost:5001/api/eventos").subscribe(
    response => this.eventos = response,
    error => console.log(error)

    );

  }

}
