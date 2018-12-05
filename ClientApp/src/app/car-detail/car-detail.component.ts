import { Component, OnInit } from '@angular/core';
import { Car } from '../car';
import { CarService } from '../car.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css']
})
export class CarDetailComponent implements OnInit {

selectedCar: Car[];


  constructor(private route: ActivatedRoute,
              private carService: CarService) 
  {

  }

  ngOnInit() {
  this.getCarDetails();
  
  }

  getCarDetails(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.carService.getCarFromId(id)
    .subscribe(selectedCar => this.selectedCar = selectedCar);
    
  }

 


}