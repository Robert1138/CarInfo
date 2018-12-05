import { Component, OnInit } from '@angular/core';
import { Car } from '../car';
import { CarService } from '../car.service';

@Component({
  selector: 'app-browse-cars',
  templateUrl: './browse-cars.component.html',
  styleUrls: ['./browse-cars.component.css']
})
export class BrowseCarsComponent implements OnInit {

  cars: Car[];
  test: string;
  constructor(private carService: CarService) { }

  ngOnInit() {
    console.log("Test (the select box) has been set to this" + this.test);
  }


  // get the cars from the make 
  getCars(): void {
    this.carService.getCarsOfMake(this.test)
    .subscribe(cars => this.cars = cars);
    
  }


  showCars(): void {
    this.test = "Acura";
    this.getCars();
    console.log("Cars are being shown");
  }


}
