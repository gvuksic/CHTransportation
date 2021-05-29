//
//  SearchViewController.swift
//  CHTransportation
//
//  Created by Goran Vuksic on 29/05/2021.
//

import Foundation
import UIKit
import MapKit

class SearchViewController: UIViewController {
    
    @IBOutlet weak var buttonSearch: UIButton!
    @IBOutlet private var mapView: MKMapView!

    // set to Budapest
    let initialLocation = CLLocation(latitude: 47.49673815991814, longitude: 19.04577901950831)
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.

        self.buttonSearch.layer.cornerRadius = 10.0
        
        // position map
        mapView.centerToLocation(initialLocation)
        
    }

}

private extension MKMapView {
    
  func centerToLocation(
    _ location: CLLocation,
    regionRadius: CLLocationDistance = 10000
  ) {
    
    let coordinateRegion = MKCoordinateRegion(
      center: location.coordinate,
      latitudinalMeters: regionRadius,
      longitudinalMeters: regionRadius)
    setRegion(coordinateRegion, animated: true)
    
  }
    
}

