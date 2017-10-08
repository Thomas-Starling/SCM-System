//
//  InitialWindowViewController.swift
//  MyUniLife
//
//  Created by Tom Starling on 07/10/2017.
//  Copyright © 2017 Tom Starling. All rights reserved.
//

import UIKit

class InitialViewController: UIViewController {
    
    //----------------------UI Elements----------------------
    //Main Window
    @IBOutlet weak var webViewBG: UIWebView!
    @IBOutlet weak var loginButton: UIButton!
    @IBOutlet weak var signUpButton: UIButton!
    //-------------------------------------------------------
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        
        let login = UserDefaults.standard
        if login.bool(forKey: "loggedIn") == true {
            let storyboard = UIStoryboard(name: "MainScreen", bundle: nil)
            let controller = storyboard.instantiateViewController(withIdentifier: "tabController")
            
            self.present(controller, animated: true, completion: nil)
        }
        else
        {
            login.set(false, forKey: "loggedIn")
        }
        
        let htmlPath = Bundle.main.path(forResource: "WebViewContent", ofType: "html")
        let htmlURL = URL(fileURLWithPath: htmlPath!)
        let html = try? Data(contentsOf: htmlURL)
        
        self.webViewBG.load(html!, mimeType: "text/html", textEncodingName: "UTF-8", baseURL: htmlURL.deletingLastPathComponent())
        
        self.loginButton.layer.borderColor = UIColor.white.cgColor
        self.loginButton.layer.borderWidth = 2
        self.signUpButton.layer.borderColor = UIColor.white.cgColor
        self.signUpButton.layer.borderWidth = 2
    }
    
    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
    }
}
