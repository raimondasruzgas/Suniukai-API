import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pagrindinis',
  templateUrl: './pagrindinis.component.html',
  styleUrls: ['./pagrindinis.component.css']
})
export class PagrindinisComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  apiNuoroda = "https://suniukai-api1.herokuapp.com/"
  gautasJSON = JSON.stringify(JSON.parse('{ "vardas": "Bobikas 1", "nuotrauka": "https://images.dog.ceo/breeds/spaniel-welsh/n02102177_3603.jpg" }'),null,4)
  nuotrauka = "https://images.dog.ceo/breeds/spaniel-welsh/n02102177_3603.jpg"

  async gautiSuniuka(){
    let atsakymasIsServerio = await fetch(this.apiNuoroda)
    let suniukas = await atsakymasIsServerio.json()
    this.nuotrauka = suniukas.nuotrauka
    this.gautasJSON = JSON.stringify(suniukas,null,4)
  }

}
