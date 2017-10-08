//
//  RecoveryViewController.swift
//  MyUniLife
//
//  Created by Tom Starling on 07/10/2017.
//  Copyright © 2017 Tom Starling. All rights reserved.
//

import UIKit
import Firebase
import FirebaseAuth

class RecoveryViewController: UIViewController {
    
    //----------------------UI Elements----------------------
    //Recovery
    @IBOutlet weak var recoveryEmailAddress: UITextField!
    //-------------------------------------------------------
    
    override func viewDidLoad() {
        super.viewDidLoad()
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
    }
    
    func errorCode(message: String) { 
        let alertController = UIAlertController(title: "Error", message: message, preferredStyle: .alert)
        
        let defaultAction = UIAlertAction(title: "OK", style: .cancel, handler: nil)
        alertController.addAction(defaultAction)
        
        self.present(alertController, animated: true, completion: nil)
    }
    
    @IBAction func recover(_ sender: Any) {
        if self.recoveryEmailAddress.text == "" {
            let alertController = UIAlertController(title: "Error", message: "Please enter your email", preferredStyle: .alert)
            
            let defaultAction = UIAlertAction(title: "OK", style: .cancel, handler: nil)
            alertController.addAction(defaultAction)
            
            present(alertController, animated: true, completion: nil)
            
        } else {
            Auth.auth().sendPasswordReset(withEmail: recoveryEmailAddress.text!) { (error) in
                if error == nil {
                    let alertController = UIAlertController(title: "Success", message: "Remember to check your spam!", preferredStyle: .alert)
                    
                    let defaultAction = UIAlertAction(title: "OK", style: .cancel, handler: nil)
                    alertController.addAction(defaultAction)
                    
                    self.present(alertController, animated: true, completion: nil)
                    
                    self.recoveryEmailAddress.text = ""
                } else {
                    if let errCode = AuthErrorCode(rawValue: error!._code) {
                        
                        switch errCode {
                        case .invalidEmail:
                            self.errorCode(message: "Invalid email address entered")
                        case .userNotFound:
                            self.errorCode(message: "Email address was not recognised")
                        case .networkError:
                            self.errorCode(message: "Network error - please check your connection")
                        default:
                            self.errorCode(message: "\(String(describing: error))")
                        }
                    }
                }
            }
        }
    }
}
