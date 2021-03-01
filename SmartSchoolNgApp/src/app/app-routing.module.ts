import { NotfoundComponent } from './shared/notfound/notfound.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { PerfilComponent } from './components/perfil/perfil.component';
import { ProfessoresComponent } from './components/professores/professores.component';
import { AlunosComponent } from './components/alunos/alunos.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
    {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full' 
    },
    {
        path: 'alunos',
        component: AlunosComponent
    },
    {
        path: 'alunos/:id',
        component: AlunosComponent
    },
    {
        path: 'professores',
        component: ProfessoresComponent
    },
    {
        path: 'professores/:id',
        component: ProfessoresComponent
    },
    {
        path: 'perfil',
        component: PerfilComponent
    },
    {
        path: 'dashboard',
        component: DashboardComponent
    },
    {
        path: '**',
        component: NotfoundComponent
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
