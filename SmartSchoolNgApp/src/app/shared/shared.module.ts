import { TitleComponent } from './title/title.component';
import { NgModule } from "@angular/core";
import { NavComponent } from "./nav/nav.component";
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
    ],
    declarations: [
        NavComponent,
        TitleComponent
    ],
    exports: [
        NavComponent,
        TitleComponent    
    ],
    providers: []
})
export class SharedModule { }