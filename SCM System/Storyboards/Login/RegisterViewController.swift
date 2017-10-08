//
//  RegisterViewController.swift
//  MyUniLife
//
//  Created by Tom Starling on 07/10/2017.
//  Copyright © 2017 Tom Starling. All rights reserved.
//

import UIKit
import Firebase
import FirebaseAuth

class RegisterViewController: UIViewController {
    
    //----------------------UI Elements----------------------
    //Register
    @IBOutlet weak var regEmailAddress: UITextField!
    @IBOutlet weak var regConfirmEmailAddress: UITextField!
    @IBOutlet weak var regPassword: UITextField!
    @IBOutlet weak var regConfirmPassword: UITextField!
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
    
    @IBAction func register(_ sender: Any) {
        if self.regEmailAddress.text == "" || self.regPassword.text == "" {
            self.errorCode(message: "Please enter your email and password")
        } else if regPassword.text != regConfirmPassword.text {
            self.errorCode(message: "Passwords do not match")
        } else if regEmailAddress.text != regConfirmEmailAddress.text {
            self.errorCode(message: "Emails do not match")
        } else {
            Auth.auth().createUser(withEmail: regEmailAddress.text!, password: regPassword.text!) { (user, error) in
                
                if error == nil {
                    user?.sendEmailVerification(completion: nil)
                    
                    let alertController = UIAlertController(title: "Success", message: "A verification email has been sent to " + self.regEmailAddress.text!, preferredStyle: .alert)
                    
                    let defaultAction = UIAlertAction(title: "OK", style: .cancel, handler: nil)
                    alertController.addAction(defaultAction)
                    
                    self.present(alertController, animated: true, completion: nil)
                    
                    self.regEmailAddress.text = ""
                    self.regConfirmEmailAddress.text = ""
                    self.regPassword.text = ""
                    self.regConfirmPassword.text = ""
                } else {
                    self.errorCode(message: (error?.localizedDescription)!)
                    if let errCode = AuthErrorCode(rawValue: error!._code) {
                        
                        switch errCode {
                        case .invalidEmail:
                            self.errorCode(message: "Invalid email address entered")
                        case .networkError:
                            self.errorCode(message: "Network error - please check your connection")
                        case .emailAlreadyInUse:
                            self.errorCode(message: "The email \(self.regEmailAddress.text!) is already in use")
                        default:
                            self.errorCode(message: "\(String(describing: error))")
                        }
                        
                        //Go back to login page
                        self.navigationController?.popToRootViewController(animated: true)
                    }
                }
            }
        }
    }
}
