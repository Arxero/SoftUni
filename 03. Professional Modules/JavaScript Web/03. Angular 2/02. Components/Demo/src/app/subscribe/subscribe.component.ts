import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Game } from '../domain/game';

@Component({
    selector: 'app-subscribe',
    templateUrl: './subscribe.component.html',
    styleUrls: ['./subscribe.component.css']
})
export class SubscribeComponent implements OnInit {
    @Input('subGame') subGame: Game
    @Output() notification = new EventEmitter<string>()
    constructor() { }

    showSubscribtion() {
        console.log(this.subGame.id)
        this.notification.emit('Success')
    }

    ngOnInit() {
        
    }

}
