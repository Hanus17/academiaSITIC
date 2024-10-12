interface AudioPlayer {
    audioVolume: number;
    songDuration: number,
    song: string,
    details: Details
}

interface Details{
    author: string;
    year: number;
}

const AudioPlayer:AudioPlayer = {
    audioVolume: 90,
    songDuration: 36,
    song: "Misery Business",
    details: {
        author: 'Hayley Williams',
        year: 2007

    }
}

console.log('song', AudioPlayer.song)
console.log('song', AudioPlayer.songDuration)
console.log('song', AudioPlayer.audioVolume)

const {song: anhotherSong, songDuration: duracion, audioVolume} = AudioPlayer;
console.log({anhotherSong, duracion, audioVolume});

const {author} = AudioPlayer.details
console.log('author', author)

// const players: string[] = ['Messi','Terstegen','Ronaldo'];
// console.log('Personaje 1', players[0] || 'No encontrado');

// const Messi = players[1] || 'No encontrado';
// console.log('Personaje 1', Messi);

const [Messi, Terstegen, Ronaldo]: string[] = ['Messi','Terstegen','Ronaldo'];
const [, , sakura = 'No encontrado']: string[] = ['Messi', 'Terstegen', 'Ronaldo'];
console.log(Messi);


export{};