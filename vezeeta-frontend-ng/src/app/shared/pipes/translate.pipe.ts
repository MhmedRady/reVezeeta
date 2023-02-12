import { Pipe, PipeTransform } from '@angular/core';
import {TranslationService} from "../services/translation.service";

@Pipe({
  name: 'Translate',
  pure: false
})
export class TranslatePipe implements PipeTransform {
  constructor(private translationService: TranslationService) {
  }
  transform(value: string, ...args: unknown[]): unknown {
    return this.translationService.translate(value);
  }

}
