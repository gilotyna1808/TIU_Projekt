import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { element } from 'protractor';
import { WyscigDTO } from '../wyscig/wyscig.component';
import { WyscigiService } from '../wyscigi.service';

@Component({
  selector: 'app-wyscigi-form',
  templateUrl: './wyscigi-form.component.html',
  styleUrls: ['./wyscigi-form.component.css']
})
export class WyscigiFormComponent implements OnInit {
  form:FormGroup;
  id:number=0;

  constructor(private formBuilder:FormBuilder, private wyscigService:WyscigiService,private route:ActivatedRoute, private router:Router) { }

  ngOnInit(): void {
    const idTemp = Number.parseInt(this.route.snapshot.paramMap.get('id'));
    if(idTemp>0){
      this.id=idTemp;
      this.wyscigService.pobierzWyscig(idTemp).subscribe(res => this.createForm(res))
    }else{
      this.createForm();
    }
  }

  private createForm(wyscig?:WyscigDTO){
    this.form=this.formBuilder.group(
      {
        data: new FormControl(wyscig?.dateTime),
        Kon1: new FormControl(wyscig?.kon1),
        Kon2: new FormControl(wyscig?.kon2),
        Kon3: new FormControl(wyscig?.kon3),
        Kon4: new FormControl(wyscig?.kon4),
        Kon5: new FormControl(wyscig?.kon5),
        KonKurs1: new FormControl(wyscig?.kursKon1),
        KonKurs2: new FormControl(wyscig?.kursKon2),
        KonKurs3: new FormControl(wyscig?.kursKon3),
        KonKurs4: new FormControl(wyscig?.kursKon4),
        KonKurs5: new FormControl(wyscig?.kursKon5),
      }
    )
  }


  onSubmit(){
    if(this.id==0)this.wyscigService.dodajWyscig(this.form.value).subscribe(res => console.log(res));
    if(this.id>0)this.wyscigService.edytujWyscig(this.form.value).subscribe(res=> console.log(res));
    this.router.navigateByUrl('wyscigi');
  }

}
