import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatAn'
})
export class FormatAnPipe implements PipeTransform {

  transform(value: number): string {
    if (value < 2000) {
      return `'${value % 100}`;
    } else {
      return `${value}`;
    }
  }

}
