//
//  SearchResultsTable.swift
//  CHTransportation
//
//  Created by Goran Vuksic on 29/05/2021.
//

import Foundation
import UIKit

class SearchResultsTable: UITableViewController {

    override func numberOfSections(in tableView: UITableView) -> Int {
        return 1
    }
    
    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return 6
    }
    
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: "searchResult", for: indexPath) as! CustomCell
        
        switch indexPath.row {
        case 0:
            cell.labelTime.text = "15:02"
            cell.labelOccupancy.text = "Predicted occupancy: high"
            cell.imageOccupancy1.image = UIImage.init(named: "user")
            cell.imageOccupancy2.image = UIImage.init(named: "user")
            cell.imageOccupancy3.image = UIImage.init(named: "user")
            cell.imageOccupancy4.image = UIImage.init(named: "user")
            cell.imageOccupancy5.image = UIImage.init(named: "user")
            cell.imageOccupancy6.image = UIImage.init(named: "user")
            cell.imageOccupancy7.image = UIImage.init(named: "userempty")
            cell.imageOccupancy8.image = UIImage.init(named: "userempty")
        case 1:
            cell.labelTime.text = "15:47"
            cell.labelOccupancy.text = "Predicted occupancy: medium"
            cell.imageOccupancy1.image = UIImage.init(named: "user")
            cell.imageOccupancy2.image = UIImage.init(named: "user")
            cell.imageOccupancy3.image = UIImage.init(named: "user")
            cell.imageOccupancy4.image = UIImage.init(named: "user")
            cell.imageOccupancy5.image = UIImage.init(named: "userempty")
            cell.imageOccupancy6.image = UIImage.init(named: "userempty")
            cell.imageOccupancy7.image = UIImage.init(named: "userempty")
            cell.imageOccupancy8.image = UIImage.init(named: "userempty")
        case 2:
            cell.labelTime.text = "16:17"
            cell.labelOccupancy.text = "Predicted occupancy: low"
            cell.imageOccupancy1.image = UIImage.init(named: "user")
            cell.imageOccupancy2.image = UIImage.init(named: "userempty")
            cell.imageOccupancy3.image = UIImage.init(named: "userempty")
            cell.imageOccupancy4.image = UIImage.init(named: "userempty")
            cell.imageOccupancy5.image = UIImage.init(named: "userempty")
            cell.imageOccupancy6.image = UIImage.init(named: "userempty")
            cell.imageOccupancy7.image = UIImage.init(named: "userempty")
            cell.imageOccupancy8.image = UIImage.init(named: "userempty")
        case 3:
            cell.labelTime.text = "16:55"
            cell.labelOccupancy.text = "Predicted occupancy: high"
            cell.imageOccupancy1.image = UIImage.init(named: "user")
            cell.imageOccupancy2.image = UIImage.init(named: "user")
            cell.imageOccupancy3.image = UIImage.init(named: "user")
            cell.imageOccupancy4.image = UIImage.init(named: "user")
            cell.imageOccupancy5.image = UIImage.init(named: "user")
            cell.imageOccupancy6.image = UIImage.init(named: "user")
            cell.imageOccupancy7.image = UIImage.init(named: "user")
            cell.imageOccupancy8.image = UIImage.init(named: "userempty")
        case 4:
            cell.labelTime.text = "17:15"
            cell.labelOccupancy.text = "Predicted occupancy: medium"
            cell.imageOccupancy1.image = UIImage.init(named: "user")
            cell.imageOccupancy2.image = UIImage.init(named: "user")
            cell.imageOccupancy3.image = UIImage.init(named: "user")
            cell.imageOccupancy4.image = UIImage.init(named: "userempty")
            cell.imageOccupancy5.image = UIImage.init(named: "userempty")
            cell.imageOccupancy6.image = UIImage.init(named: "userempty")
            cell.imageOccupancy7.image = UIImage.init(named: "userempty")
            cell.imageOccupancy8.image = UIImage.init(named: "userempty")
        case 5:
            cell.labelTime.text = "17:40"
            cell.labelOccupancy.text = "Predicted occupancy: high"
            cell.imageOccupancy1.image = UIImage.init(named: "user")
            cell.imageOccupancy2.image = UIImage.init(named: "user")
            cell.imageOccupancy3.image = UIImage.init(named: "user")
            cell.imageOccupancy4.image = UIImage.init(named: "user")
            cell.imageOccupancy5.image = UIImage.init(named: "user")
            cell.imageOccupancy6.image = UIImage.init(named: "user")
            cell.imageOccupancy7.image = UIImage.init(named: "user")
            cell.imageOccupancy8.image = UIImage.init(named: "userempty")
        default:
            cell.labelTime.text = "18:00"
        }
        
        return cell
    }
    
    override func tableView(_ tableView: UITableView, heightForRowAt indexPath: IndexPath) -> CGFloat {
        // default height
        return 120
    }
    
}
