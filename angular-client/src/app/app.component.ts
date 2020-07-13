import { Component, OnInit } from '@angular/core';
import { DataProviderService } from './data-provider.service';
import { Model } from './model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  data: Array<Model>;

  constructor(private _dataProvider: DataProviderService) {
  }

  async ngOnInit() {
    this.data = await this._dataProvider.getData();
    console.log(this.data);
  }
}
