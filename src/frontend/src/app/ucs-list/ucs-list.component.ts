import { Component, OnInit } from '@angular/core';
import { Uc, UcService } from '../uc.service';

@Component({
  selector: 'app-ucs-list',
  templateUrl: './ucs-list.component.html',
  styleUrls: ['./ucs-list.component.scss']
})
export class UcsListComponent implements OnInit {

  ucs: Uc[];

  constructor(private ucService: UcService) { }

  ngOnInit(): void {
    this.ucService.getUcs().subscribe(data => this.ucs = data);
  }
}
