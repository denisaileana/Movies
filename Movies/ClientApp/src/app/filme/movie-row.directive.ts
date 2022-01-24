import {AfterViewInit, Directive, ElementRef, HostListener, Input} from '@angular/core';
import {Router} from '@angular/router';

@Directive({
  selector: '[appMovieRow]'
})
export class MovieRowDirective implements AfterViewInit {
  @Input() appMovieRow!: number;

  constructor(private el: ElementRef, private router: Router) {
  }

  @HostListener('click')
  onClick() {
    this.router.navigate(['/filme', this.appMovieRow]);
  }

  ngAfterViewInit(): void {
    this.el.nativeElement.style.cursor = 'pointer';
  }
}
