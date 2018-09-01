import { Component, OnInit } from '@angular/core';
import { Game } from '../domain/game';

@Component({
    selector: 'app-game',
    templateUrl: './game.component.html',
    styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {
    games: Array<Game>
    isShown: boolean = false
    username: string

    constructor() {
        this.games = [
            { id: 1, title: 'Maverick Game', image: 'http://secure.gravatar.com/avatar/20bcadf166bce64de3cf4cdeb266ab99?s=150' },
            { id: 2, title: 'Bikini Girl Game', image: 'http://awesomecs.syntrwave.com/images/avatars/gallery/gtavc_anniversary_Bikini_Girl_150x150.jpg' },
        ]
    }

    notyfyMe(notification: string) {
        console.log(notification)
        
    }

    showName(name) {
        this.username = name
        console.log(name)

    }

    showContacts() {
        this.isShown = !this.isShown
    }

    ngOnInit() {
    }

}
