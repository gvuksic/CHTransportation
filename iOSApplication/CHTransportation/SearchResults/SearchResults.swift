//
//  SearchResults.swift
//  CHTransportation
//
//  Created by Goran Vuksic on 29/05/2021.
//

import Foundation
import UIKit

class SearchResults: UIViewController, UITableViewDelegate {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    func tableView(_ tableView: UITableView, heightForRowAt indexPath: IndexPath) -> CGFloat {
        return 120
    }

}

