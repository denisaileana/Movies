import {Component, OnInit} from '@angular/core';
import {Gen, GenuriService} from './genuri.service';

@Component({
  selector: 'app-genuri',
  templateUrl: './genuri.component.html',
  styleUrls: ['./genuri.component.css']
})
export class GenuriComponent implements OnInit {

  genuri: Gen[] = [];

  constructor(private genuriService: GenuriService) {
  }

  ngOnInit() {
    this.genuriService.getGenuri().subscribe(genuri => this.genuri = genuri);
  }

}
