import { RouterModule } from '@angular/router';
import { SharedModule } from './../shared/shared.module';
import { ProfessoresComponent } from './professores/professores.component';
import { PerfilComponent } from './perfil/perfil.component';
import { AlunosComponent } from './alunos/alunos.component';
import { NgModule } from "@angular/core";
import { DashboardComponent } from './dashboard/dashboard.component';
import { CommonModule } from '@angular/common';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        SharedModule,
    ],
    declarations: [
        PerfilComponent,
        AlunosComponent,
        ProfessoresComponent,
        DashboardComponent,
    ],
    exports: [
        PerfilComponent,
        AlunosComponent,
        ProfessoresComponent,
        DashboardComponent,    
    ],
    providers: []
})
export class ComponentsModule { }