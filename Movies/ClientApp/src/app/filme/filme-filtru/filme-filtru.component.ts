import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';

@Component({
  selector: 'app-filme-filtru',
  templateUrl: './filme-filtru.component.html',
  styleUrls: ['./filme-filtru.component.css']
})
export class FilmeFiltruComponent implements OnInit {

  @Input() valoare = '';
  @Output() valoareChange = new EventEmitter<string>();

  constructor() { }

  ngOnInit() {
  }

  onChange(valoare: string) {
    this.valoare = valoare;
    this.valoareChange.emit(this.valoare);
  }
}
