import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

const urlBase = "https://localhost:44351/api";

@Injectable({
  providedIn: 'root'
})
export class UcService {

  constructor(private httpClient: HttpClient) { }

  getUcs() {
    return this.httpClient.get<Uc[]>(`${urlBase}/ucs`);
  }
}

export interface Uc {
  id: number;
  consumerName: string;
  coordinates: Coordinates;
  region: Region;
  locality: Locality;
  municipality: Municipality;
  neighborhood: Neighborhood;
  meterType: MeterType;
  ucClass: UcClass;
  phase: Phase;
  activityField: ActivityField;
  voltageLevel: VoltageLevel;
}

export interface Coordinates {
  latitude: number;
  longitude: number;
}

interface Base {
  id: number;
  name: string;
  description: string;
}

export interface Region extends Base { }
export interface Locality extends Base { }
export interface Municipality extends Base { }
export interface Neighborhood extends Base { }
export interface MeterType extends Base { }
export interface UcClass extends Base { }
export interface Phase extends Base { }
export interface ActivityField extends Base { }
export interface VoltageLevel extends Base { }