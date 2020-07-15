import { Component } from '@angular/core';
import { DataProviderService } from './data-provider.service';
import { Model } from './model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  data: Array<Model>;
  sendValue = 0;

  constructor(private _dataProvider: DataProviderService) {
  }

  async getData() {
    this.data = await this._dataProvider.getData();
  }

  sendData() {
    this._dataProvider.sendData(this.sendValue);
  }
}
