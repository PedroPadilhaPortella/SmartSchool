import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { Disciplina } from 'src/app/models/Disciplina';
import { Professor } from 'src/app/models/Professor';
import { Util } from 'src/app/utils/utils';

@Component({
    selector: 'app-professores-alunos',
    templateUrl: './professores-alunos.component.html'
})
export class ProfessoresAlunosComponent implements OnInit {

    @Input() public professores: Professor[];
    @Output() closeModal = new EventEmitter();

    constructor(private router: Router) { }

    ngOnInit(): void {
        console.log(this.professores);
    }

    disciplinaConcat(disciplinas: Disciplina[]): string {
        return Util.nomeConcat(disciplinas);
    }

    professorSelect(prof: Professor): void {
        this.closeModal.emit(null);
        this.router.navigate(['/professor', prof.id]);
    }
}
