import { Directive, ElementRef, HostListener, OnDestroy, Renderer2 } from '@angular/core';

@Directive({
  selector: '[cardImageHoverPopup]'
})
export class CardImageHoverPopupDirective implements OnDestroy {
  private popup: HTMLElement;

  constructor(private el: ElementRef, private renderer: Renderer2) { }

  @HostListener('mouseenter') onMouseEnter() {
    this.createPopup();
  }

  @HostListener('mousemove', ['$event']) onMouseMove(event: MouseEvent) {
    this.positionPopup(event);
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.destroyPopup();
  }

  ngOnDestroy() {
    this.destroyPopup();
  }

  private createPopup() {
    const card = this.el.nativeElement.getAttribute('data-card');
    const imageUrl = JSON.parse(card).ImageUrl;

    this.popup = this.renderer.createElement('img');
    this.renderer.setStyle(this.popup, 'position', 'absolute');
    this.renderer.setStyle(this.popup, 'height', '250px');
    this.renderer.setStyle(this.popup, 'pointer-events', 'none');
    this.renderer.setStyle(this.popup, 'z-index', '9999');
    this.renderer.setAttribute(this.popup, 'src', imageUrl);

    this.renderer.appendChild(document.body, this.popup);
  }

  private positionPopup(event: MouseEvent) {
    const scrollY = window.scrollY || window.pageYOffset;
    const scrollX = window.scrollX || window.pageXOffset;
    const popupHeight = this.popup.offsetHeight;
    const popupWidth = this.popup.offsetWidth;
    this.renderer.setStyle(this.popup, 'top', `${event.clientY + scrollY - popupHeight / 2}px`);
    this.renderer.setStyle(this.popup, 'left', `${event.clientX + scrollX - popupWidth / 2}px`);
  }

  private destroyPopup() {
    if (this.popup) {
      this.renderer.removeChild(document.body, this.popup);
      this.popup = null;
    }
  }
}
