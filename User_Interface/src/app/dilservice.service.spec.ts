import { TestBed } from '@angular/core/testing';
import { DilserviceService } from './dilservice.service';

describe('DilserviceService', () => {
  let service: DilserviceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DilserviceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
